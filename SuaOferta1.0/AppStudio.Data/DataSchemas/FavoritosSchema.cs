using System;
using System.Collections;

namespace AppStudio.Data
{
    /// <summary>
    /// Implementation of the FavoritosSchema class.
    /// </summary>
    public class FavoritosSchema : BindableSchemaBase, IEquatable<FavoritosSchema>
    {
        private string _nomeProduto;
        private string _preco;
        private string _descricao;
        private string _dataInicio;
        private string _dataVencimento;
        private string _imagemOne;
        private string _imagemTwo;
        private string _cordenadaX;
        private string _cordenadaY;
         
        public string NomeProduto
        {
            get { return _nomeProduto; }
            set { SetProperty(ref _nomeProduto, value); }
        }
 
        public string Preco
        {
            get { return _preco; }
            set { SetProperty(ref _preco, value); }
        }
 
        public string Descricao
        {
            get { return _descricao; }
            set { SetProperty(ref _descricao, value); }
        }
 
        public string DataInicio
        {
            get { return _dataInicio; }
            set { SetProperty(ref _dataInicio, value); }
        }
 
        public string DataVencimento
        {
            get { return _dataVencimento; }
            set { SetProperty(ref _dataVencimento, value); }
        }
 
        public string ImagemOne
        {
            get { return _imagemOne; }
            set { SetProperty(ref _imagemOne, value); }
        }
 
        public string ImagemTwo
        {
            get { return _imagemTwo; }
            set { SetProperty(ref _imagemTwo, value); }
        }
 
        public string CordenadaX
        {
            get { return _cordenadaX; }
            set { SetProperty(ref _cordenadaX, value); }
        }
 
        public string CordenadaY
        {
            get { return _cordenadaY; }
            set { SetProperty(ref _cordenadaY, value); }
        }

        public override string DefaultTitle
        {
            get { return NomeProduto; }
        }

        public override string DefaultSummary
        {
            get { return Preco; }
        }

        public override string DefaultImageUrl
        {
            get { return ImagemOne; }
        }

        public override string DefaultContent
        {
            get { return Preco; }
        }

        override public string GetValue(string fieldName)
        {
            if (!String.IsNullOrEmpty(fieldName))
            {
                switch (fieldName.ToLowerInvariant())
                {
                    case "nomeproduto":
                        return String.Format("{0}", NomeProduto); 
                    case "preco":
                        return String.Format("{0}", Preco); 
                    case "descricao":
                        return String.Format("{0}", Descricao); 
                    case "datainicio":
                        return String.Format("{0}", DataInicio); 
                    case "datavencimento":
                        return String.Format("{0}", DataVencimento); 
                    case "imagemone":
                        return String.Format("{0}", ImagemOne); 
                    case "imagemtwo":
                        return String.Format("{0}", ImagemTwo); 
                    case "cordenadax":
                        return String.Format("{0}", CordenadaX); 
                    case "cordenaday":
                        return String.Format("{0}", CordenadaY); 
                    case "defaulttitle":
                        return DefaultTitle;
                    case "defaultsummary":
                        return DefaultSummary;
                    case "defaultimageurl":
                        return DefaultImageUrl;
                    default:
                        break;
                }
            }
            return String.Empty;
        }


        public bool Equals(FavoritosSchema other)
        {
            if (other == null)
            {
                return false;
            }

            return this.NomeProduto == other.NomeProduto && this.Preco == other.Preco && this.Descricao == other.Descricao && this.DataInicio == other.DataInicio && this.DataVencimento == other.DataVencimento && this.ImagemOne == other.ImagemOne && this.ImagemTwo == other.ImagemTwo && this.CordenadaX == other.CordenadaX && this.CordenadaY == other.CordenadaY;
        }
    }
}
