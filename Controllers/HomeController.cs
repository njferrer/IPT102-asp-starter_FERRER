using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var studentInfoArray = new[]
        {
            new StudentInfoModel { Name = "ZHAO LUSI", StudentId = "21-001", StudentAge = "5" },
            new StudentInfoModel { Name = "NICOLE JOY", StudentId = "21-002", StudentAge = "72" },
            new StudentInfoModel { Name = "FERRER", StudentId = "21-003", StudentAge = "81" }
            new StudentInfoModel { Name = "NJ", StudentId = "22-007", StudentAge = "41" }

        };

        return View(studentInfoArray);
    }
}
