
//MainActivity.cs

using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;

namespace Tradutor
{
    [Activity(Label = "Tradutor", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            var novaPalavra = FindViewById<Button>(Resource.Id.novaPalavra);
            var Palavra = FindViewById<TextView>(Resource.Id.Palavra);
            var Traducao = FindViewById<EditText>(Resource.Id.Traducao);
            var Traduzir = FindViewById<Button>(Resource.Id.Traduzir);
            var Resposta = FindViewById<TextView>(Resource.Id.Resposta);
            var Pontuacao = FindViewById<TextView>(Resource.Id.Pontuacao);

            IList<clsTradutor.Tradutor.Palavras> ListaPalavras;
            string f_ptbr = string.Empty;
            string f_us = string.Empty;
            int w_intPontos = 0;

            novaPalavra.Click += (sender, e) =>
            {
                ListaPalavras = clsTradutor.Tradutor.Lista_de_Palavras();
                foreach (var i in ListaPalavras)
                {
                    f_us = "Palavra: " + i.Ingles;
                    Palavra.Text = f_us;
                    f_ptbr = i.Portugues;
                    Traducao.Text = "";
                    Resposta.Text = "Resposta:";
                }
            };
            Traduzir.Click += (sender, e) =>
            {
                if (Traducao.Text != "")
                {
                    if (Traducao.Text == f_ptbr)
                    {
                        Resposta.Text = "Resposta: " + "Correto";
                        w_intPontos += 1;
                        Pontuacao.Text = "Pontuação: " + w_intPontos.ToString();
                    }
                    else if (Traducao.Text != f_us)
                    {
                        Resposta.Text = "Resposta: " + "Incorreto";
                    }
                }
            };
        }
    }
}

