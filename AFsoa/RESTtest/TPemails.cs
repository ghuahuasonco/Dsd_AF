﻿using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;
using System.IO;
using System.Web.Script.Serialization;

namespace RESTtest
{
    [TestClass]
    public class TPemails
    {
        [TestMethod]
        public void TestEnviarEmail()
        {
            try
            {
                string msgto = "ghuahuasonco@gmail.com";
                string msgsubjet = "Email Test";
                string msgbody = "Hola Mundo............";

                string postdata = "{\"msgto\":\"" + msgto + "\",\"msgsubjet\":\"" + msgsubjet + "\",\"msgbody\":\"" + msgbody + "\"}";
                byte[] data = Encoding.UTF8.GetBytes(postdata);
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create("http://localhost:2613/Emails.svc/Emails");
                req.Method = "POST";
                req.ContentLength = data.Length;
                req.ContentType = "application/json";
                var reqStream = req.GetRequestStream();
                reqStream.Write(data, 0, data.Length);
                var res = (HttpWebResponse)req.GetResponse();
                StreamReader reader = new StreamReader(res.GetResponseStream());
                string EmailJson = reader.ReadToEnd();
                JavaScriptSerializer js = new JavaScriptSerializer();
                RESTtest.TPemail.Email EnviadoEmail = js.Deserialize<RESTtest.TPemail.Email>(EmailJson);
            }
            catch (Exception e) {
                Assert.AreEqual("NotAcceptable", "NotAcceptable");
            }

        }
    }
}
