namespace SiteWeb.Models
{

    /*Formate le renvoie du retour Json par requête AJAX*/
    public class JsonResultModel
    {
        #region Properties

        public bool Success { get; set; }
        public object Data { get; set; }
        public string ErrorMessage { get; set; }

        #endregion
    }
}
