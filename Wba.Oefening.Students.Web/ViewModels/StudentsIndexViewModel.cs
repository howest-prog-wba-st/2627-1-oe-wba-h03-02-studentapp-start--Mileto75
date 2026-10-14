namespace Wba.Oefening.Students.Web.ViewModels
{
    public class StudentsIndexViewModel
    {
        //pageTitle
        public string PageTitle { get; set; }
        //IEnumerable<BaseViewModel> 
        public IEnumerable<BaseViewModel> Students { get; set; }
    }
}
