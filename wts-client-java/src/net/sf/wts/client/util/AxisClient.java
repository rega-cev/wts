package net.sf.wts.client.util;

import java.net.MalformedURLException;
import java.rmi.RemoteException;
import java.util.ArrayList;
import java.util.Hashtable;

import javax.xml.rpc.ParameterMode;
import javax.xml.rpc.ServiceException;

import org.apache.axis.client.Call;
import org.apache.axis.client.Service;
import org.apache.axis.encoding.XMLType;
import org.apache.axis.transport.http.HTTPConstants;

public class AxisClient 
{
    private Call call;
    private ArrayList<Object> parameters_ = new ArrayList<Object>();
    
    @SuppressWarnings({ "rawtypes", "unchecked" })
	public AxisClient()
    {
        Service service = new Service();
        try 
        {            
            call = (Call) service.createCall();

            //enable gzip compression
//            call.setProperty(HTTPConstants.MC_ACCEPT_GZIP, Boolean.TRUE);
//            call.setProperty(HTTPConstants.MC_GZIP_REQUEST, Boolean.TRUE);
            
            Hashtable headers = (Hashtable)call.getProperty(HTTPConstants.REQUEST_HEADERS);
            if(headers == null)
            	headers = new Hashtable();
            headers.put(HTTPConstants.HEADER_TRANSFER_ENCODING_CHUNKED, false);
            call.setProperty(HTTPConstants.REQUEST_HEADERS, headers);
        } 
        catch (ServiceException e) 
        {
            e.printStackTrace();
            throw new RuntimeException(e);
        }
    }
    
    public void setServiceUrl(String url, String service) throws MalformedURLException
    {
        call.setTargetEndpointAddress(new java.net.URL(url+service));

        call.setOperationName(new javax.xml.namespace.QName("urn:"+service, "exec"));
    }
    
    public void addParameter(String param)
    {
        call.addParameter("in"+parameters_.size(), XMLType.XSD_STRING, ParameterMode.IN);
        parameters_.add(param);
    }
    
    public void addParameter(int param)
    {
        call.addParameter("in"+parameters_.size(), XMLType.XSD_INT, ParameterMode.IN);
        parameters_.add(param);
    }
    
    public void addParameter(byte[] param)
    {
        call.addParameter("in"+parameters_.size(), XMLType.XSD_HEXBIN, ParameterMode.IN);
        parameters_.add(param);
    }
    
    public String callAndGetStringResult() throws RemoteException
    {
        call.setReturnType(org.apache.axis.encoding.XMLType.XSD_STRING);
        
        return (String)(call.invoke(parameters_.toArray()));
    }
    
    public byte[] callAndGetByteArrayResult() throws RemoteException
    {
        call.setReturnType(org.apache.axis.encoding.XMLType.XSD_HEXBIN);
        
        return (byte[])(call.invoke(parameters_.toArray()));
    }
    
    public void call() throws RemoteException
    {   
        call.setReturnType(org.apache.axis.encoding.XMLType.XSD_ANYTYPE);
        call.invoke(parameters_.toArray());
    }
    
    public void removeParameters()
    {
        call.removeAllParameters();
        parameters_.clear();
    }
}
