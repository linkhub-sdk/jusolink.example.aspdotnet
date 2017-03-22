using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

namespace Jusolink.Example.Example
{
    public partial class zipcode_search : System.Web.UI.Page
    {
        public String code;
        public String message;
        public SearchResult result;

        protected void Page_Load(object sender, EventArgs e)
        {   
            // 페이지번호 (기본값)
            int pageNum = 1;

            if (Request.QueryString["IndexWord"] != null)
            {
                // 검색어
                String IndexWord = Request.QueryString["IndexWord"];

                // 페이지당 목록 갯수, 최대 100개
                int perPage = 20;

                // 수정제시어 끄기
                bool noSuggest = false;

                // 차등검색 끄기
                bool noDiffer = false;      

                if (Request.QueryString["PageNum"] != null && Request.QueryString["PageNum"] != "")
                {
                    pageNum =  int.Parse(Request.QueryString["PageNum"]);
                }
                
                try
                {
                    result = Global.jusolinkService.search(IndexWord, pageNum, perPage, noSuggest, noDiffer);

                }
                catch (JusolinkException ex)
                {
                    code = ex.code.ToString();
                    message = ex.Message;
                }
            }
        }
    }
}
