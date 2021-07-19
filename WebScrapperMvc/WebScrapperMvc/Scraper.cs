
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using WebScrapperMVC.Models;


namespace WebScrapperMVC
{
    public class Scraper
    {
        private List<ImagemViewModel> _imagens = new List<ImagemViewModel>();
        private List<string> _topPalavras = new List<string>();

        public List<ImagemViewModel> Imagens
        {
            get { return _imagens; }
            set { _imagens = value; }
        }

        public List<String> topPalavras
        {
            get { return _topPalavras; }
            set { _topPalavras = value; }
        }

        public void ScrapeData(string page)
        {
            var web = new HtmlWeb();
            var data = new WebClient();
            var doc = web.Load(page);
            var imagens = doc.DocumentNode.Descendants("img")
                                .Select(e => e.GetAttributeValue("src", null))
                                .Where(s => !String.IsNullOrEmpty(s));

            char[] delimitador = new char[] { ' ',',','.','/' };

            List<string> textosSite =  doc.DocumentNode.Descendants()
                 .Where(n => n.NodeType == HtmlNodeType.Text
                 && !string.IsNullOrWhiteSpace(HtmlEntity.DeEntitize(n.InnerText))
                 && n.ParentNode.Name != "style" && n.ParentNode.Name != "script")
                .Select(n => HtmlEntity.DeEntitize(n.InnerText).Trim())    
                .Where(s => s.Length > 2 ).ToList();


            List<string> top10palavras = string.Join(" ", textosSite).Split(delimitador, StringSplitOptions.RemoveEmptyEntries)
                .GroupBy(s => s)
                .Where(g => g.Count() > 1)
                .OrderByDescending(g => g.Count())
                .Select(g => g.Key)
                .Where(g => Char.IsLetter(g[0]) && g.Length > 2)
                .Take(10)
                .ToList();


            topPalavras = top10palavras;
              
            foreach (var imagem in imagens)
            {

                if (imagem.StartsWith("https"))
                {
                    byte[] imagemDownload = data.DownloadData(imagem);
                    string resultado = Convert.ToBase64String(imagemDownload);

                    _imagens.Add(new ImagemViewModel { Imagem = resultado });
                }
            }

        }


    }
}
