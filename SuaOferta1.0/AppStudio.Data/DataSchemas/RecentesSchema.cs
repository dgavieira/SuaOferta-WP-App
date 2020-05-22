using System;
using System.Collections;

namespace AppStudio.Data
{
    /// <summary>
    /// Implementation of the RecentesSchema class.
    /// </summary>
    public class RecentesSchema : BindableSchemaBase, IEquatable<RecentesSchema>
    {
        private string _nomeProduto;
        private string _preco;
        private string _descricao;
        private string _dataInicio;
        private string _dataVencimento;
        private string _imageOne;
        private string _imageTwo;
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
 
        public string ImageOne
        {
            get { return _imageOne; }
            set { SetProperty(ref _imageOne, value); }
        }
 
        public string ImageTwo
        {
            get { return _imageTwo; }
            set { SetProperty(ref _imageTwo, value); }
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
            get { return ImageOne; }
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
                    case "imageone":
                        return String.Format("{0}", ImageOne); 
                    case "imagetwo":
                        return String.Format("{0}", ImageTwo); 
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


        public bool Equals(RecentesSchema other)
        {
            if (other == null)
            {
                return false;
            }

            return this.NomeProduto == other.NomeProduto && this.Preco == other.Preco && this.Descricao == other.Descricao && this.DataInicio == other.DataInicio && this.DataVencimento == other.DataVencimento && this.ImageOne == other.ImageOne && this.ImageTwo == other.ImageTwo && this.CordenadaX == other.CordenadaX && this.CordenadaY == other.CordenadaY;
        }
    }
}
