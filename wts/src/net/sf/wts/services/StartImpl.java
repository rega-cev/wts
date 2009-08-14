package net.sf.wts.services;

import java.io.File;
import java.io.IOException;
import java.rmi.RemoteException;

import net.sf.wts.services.util.Service;
import net.sf.wts.services.util.Sessions;
import net.sf.wts.services.util.Settings;

import org.apache.commons.io.FileUtils;

public class StartImpl 
{
    public void exec(String sessionTicket, final String serviceName) throws RemoteException
    {
        final File sessionPath = Sessions.getSessionPath(sessionTicket);
        if(sessionPath==null)
            throw new RemoteException("Your session ticket is not valid");
        Service service = Settings.getService(serviceName);
        if(service==null)
            throw new RemoteException("Service \"" + serviceName + "\" is not available");
        if(!Sessions.isSessionForService(sessionTicket, serviceName))
            throw new RemoteException("This ticket is not valid for service \"" + serviceName + "\"");
        
        final File startScript = Settings.getServiceStartScriptPath(serviceName);
        
        
        File runningJob = new File(sessionPath.getAbsolutePath()+File.separatorChar+".running");
        System.err.println("runningFile"+runningJob.getAbsolutePath());
        
        try 
        {
            FileUtils.writeByteArrayToFile(runningJob, "RUNNING".getBytes());
        } 
        catch (IOException e1) 
        {
            e1.printStackTrace();
        }
        
        Thread jobRunningThread = new Thread(new Runnable()
        {
            public void run()
            {
                try 
                {
                    ProcessBuilder pb = new ProcessBuilder(startScript.getAbsolutePath(), sessionPath.getAbsolutePath());
                    Process p = pb.start();
                } 
                catch (IOException e) 
                {
                    e.printStackTrace();
                } 
            }
        });
        
        jobRunningThread.start();
    }
}