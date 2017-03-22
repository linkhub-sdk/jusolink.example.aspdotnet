using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Xml.Linq;

namespace Jusolink.Example
{
    public class Global : System.Web.HttpApplication
    {
        // 링크아이디
        private string LinkID = "TESTER_JUSO";

        // 비밀키
        private string SecretKey = "FjaRgAfVUPvSDHTrdd/uw/dt/Cdo3GgSFKyE1+NQ+bc=";

        public static JusolinkService jusolinkService;

        protected void Application_Start(object sender, EventArgs e)
        {
            // 주소링크 API 서비스 초기화
            jusolinkService = new JusolinkService(LinkID, SecretKey);
        }
    }
}