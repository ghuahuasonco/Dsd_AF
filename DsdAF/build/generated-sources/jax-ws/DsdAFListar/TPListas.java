
package DsdAFListar;

import java.net.MalformedURLException;
import java.net.URL;
import javax.xml.namespace.QName;
import javax.xml.ws.Service;
import javax.xml.ws.WebEndpoint;
import javax.xml.ws.WebServiceClient;
import javax.xml.ws.WebServiceException;
import javax.xml.ws.WebServiceFeature;


/**
 * This class was generated by the JAX-WS RI.
 * JAX-WS RI 2.2.6-1b01 
 * Generated source version: 2.2
 * 
 */
@WebServiceClient(name = "TPListas", targetNamespace = "http://tempuri.org/", wsdlLocation = "http://localhost:1098/TPListas.svc?wsdl")
public class TPListas
    extends Service
{

    private final static URL TPLISTAS_WSDL_LOCATION;
    private final static WebServiceException TPLISTAS_EXCEPTION;
    private final static QName TPLISTAS_QNAME = new QName("http://tempuri.org/", "TPListas");

    static {
        URL url = null;
        WebServiceException e = null;
        try {
            url = new URL("http://localhost:1098/TPListas.svc?wsdl");
        } catch (MalformedURLException ex) {
            e = new WebServiceException(ex);
        }
        TPLISTAS_WSDL_LOCATION = url;
        TPLISTAS_EXCEPTION = e;
    }

    public TPListas() {
        super(__getWsdlLocation(), TPLISTAS_QNAME);
    }

    public TPListas(WebServiceFeature... features) {
        super(__getWsdlLocation(), TPLISTAS_QNAME, features);
    }

    public TPListas(URL wsdlLocation) {
        super(wsdlLocation, TPLISTAS_QNAME);
    }

    public TPListas(URL wsdlLocation, WebServiceFeature... features) {
        super(wsdlLocation, TPLISTAS_QNAME, features);
    }

    public TPListas(URL wsdlLocation, QName serviceName) {
        super(wsdlLocation, serviceName);
    }

    public TPListas(URL wsdlLocation, QName serviceName, WebServiceFeature... features) {
        super(wsdlLocation, serviceName, features);
    }

    /**
     * 
     * @return
     *     returns ITPListas
     */
    @WebEndpoint(name = "BasicHttpBinding_ITPListas")
    public ITPListas getBasicHttpBindingITPListas() {
        return super.getPort(new QName("http://tempuri.org/", "BasicHttpBinding_ITPListas"), ITPListas.class);
    }

    /**
     * 
     * @param features
     *     A list of {@link javax.xml.ws.WebServiceFeature} to configure on the proxy.  Supported features not in the <code>features</code> parameter will have their default values.
     * @return
     *     returns ITPListas
     */
    @WebEndpoint(name = "BasicHttpBinding_ITPListas")
    public ITPListas getBasicHttpBindingITPListas(WebServiceFeature... features) {
        return super.getPort(new QName("http://tempuri.org/", "BasicHttpBinding_ITPListas"), ITPListas.class, features);
    }

    private static URL __getWsdlLocation() {
        if (TPLISTAS_EXCEPTION!= null) {
            throw TPLISTAS_EXCEPTION;
        }
        return TPLISTAS_WSDL_LOCATION;
    }

}
