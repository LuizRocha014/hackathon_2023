using Hackathon_2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hackathon_2.ViewModels.ViewModelAdicionadas
{
    public class OngViewModel : BaseViewModel
    {

        private List<ong> _listONG;


        public List<ong> ListONG { get { return _listONG; } set { _listONG = value; OnPropertyChanged("ListONG"); } }

        public OngViewModel()
        {
        }

        public void CarregaDados()
        {

            var list = new List<ong>();
            var teste = new ong()
            {
                Nome= "Arca da Fé - Resgate Animal",
                Fundacao= "O trabalho desenvolvido é de resgate, tratamentos de reabilitação e cuidados para preparar os resgatados para adoção.",
                Imagem = "Arca_da_fe.png"
            };
            list.Add(teste);
            var teste1 = new ong()
            {
                Nome = "Abrigo da Borika",
                Fundacao = "Borika Hegyessy é protetora de Bauru e atualmente cuida de 280 animais entre cães e gatos",
                Imagem = "Borika_Hegyessy.png"

            };
                list.Add(teste1);
            var teste2 = new ong()
            {
                Nome = "Prana Pet",
                Fundacao = "O Abrigo Prana Pet foi criado por Michele Cruz que cuida de 150 animais.",
                Imagem = "Prana_Pet.png"
            };
            list.Add(teste2);
            var teste3 = new ong()
            {
                Nome = "SOS Gatinhos",
                Fundacao = "A ONG é um lar abrigo de Animais Idosos que abriga 103 gatos e 15 cachorros com a idade de 12 a 18 anos.",
                Imagem = "SOS_Gatinhos.png"
            };
            list.Add(teste3);
            ListONG = new List<ong>(list);
        }
    }
}
