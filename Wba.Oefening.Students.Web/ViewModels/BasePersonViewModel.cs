namespace Wba.Oefening.Students.Web.ViewModels
{
    public class BasePersonViewModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<BaseViewModel> Courses { get; set; }
    }
}
