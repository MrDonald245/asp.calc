using System.Web.Mvc;

namespace Web.Calculator.Controllers
{
    public class CalcController : Controller
    {
        // GET: Calc
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Sum two values.
        /// </summary>
        /// <param name="par1"></param>
        /// <param name="par2"></param>
        /// <returns></returns>
        public ActionResult Add(int par1, int par2)
        {
            return View(par1 + par2);
        }

        /// <summary>
        /// Minus two values.
        /// </summary>
        /// <param name="par1"></param>
        /// <param name="par2"></param>
        /// <returns></returns>
        public ActionResult Min(int par1, int par2)
        {
            return View(par1 - par2);
        }

        /// <summary>
        /// Multiply two values.
        /// </summary>
        /// <param name="par1"></param>
        /// <param name="par2"></param>
        /// <returns></returns>
        public ActionResult Mul(int par1, int par2)
        {
            return View(par1*par2);
        }

        /// <summary>
        /// Multiply
        /// </summary>
        /// <param name="par1"></param>
        /// <param name="par2"></param>
        /// <returns></returns>
        public ActionResult Div(int par1, int par2)
        {
            return View((double)par1/par2);
        }
    }
}