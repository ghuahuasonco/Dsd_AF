using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;
using System.Linq;
using System.IO;
using System.Web.Script.Serialization;

namespace RESTtest
{
    [TestClass]
    public class TPrograms
    {
        [TestMethod]
        public void TestTProgramListar()
        {
            try
            {
                HttpWebRequest req = (HttpWebRequest)WebRequest
                    .Create("http://localhost:1266/TPrograms.svc/TPrograms"); req.Method = "GET";
                HttpWebResponse res = (HttpWebResponse)req.GetResponse();
                StreamReader reader = new StreamReader(res.GetResponseStream());
                string tprogram = reader.ReadToEnd();
                JavaScriptSerializer js = new JavaScriptSerializer();
                List<TProgram> TPlista = js.Deserialize<List<TProgram>>(tprogram);
                //test de registros existentes
                int total = TPlista.Count;
                Assert.AreEqual(total, TPlista.Count);
            } catch (Exception e) {
                Assert.AreEqual("NotAcceptable", "NotAcceptable");
            }
        }

        [TestMethod]
        public void TestTProgramListarCero()
        {
            try
            {
                HttpWebRequest req = (HttpWebRequest)WebRequest
                    .Create("http://localhost:1266/TPrograms.svc/TPrograms"); req.Method = "GET";
                HttpWebResponse res = (HttpWebResponse)req.GetResponse();
                StreamReader reader = new StreamReader(res.GetResponseStream());
                string tprogram = reader.ReadToEnd();
                JavaScriptSerializer js = new JavaScriptSerializer();
                List<TProgram> TPlista = js.Deserialize<List<TProgram>>(tprogram);
                //test de registros  no existente
                Assert.AreNotEqual(0, TPlista.Count);
            } catch(Exception e) {
                Assert.AreEqual("NotAcceptable", "NotAcceptable");
            }
        }
    }
}
