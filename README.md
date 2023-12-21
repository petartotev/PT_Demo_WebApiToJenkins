# PT_Demo_WebApiToJenkins

## Contents
- [.NET Solution](#net-solution)
    - [WebApiToJenkins.Api](#webapitojenkinsapi)
    - [WebApiToJenkins.Tests](#webapitojenkinstests)
- [Setup](#setup)

## .NET Solution

The WebApiToJenkins solution contains 2 projects:
- WebApiToJenkins.Api
- WebApiToJenkins.Tests

### WebApiToJenkins.Api

### WebApiToJenkins.Tests

## Setup

1. Create Dockerfile:

```
```

2. Pull Docker Image:

```
docker pull jenkins/jenkins
```

3. Run Docker Container:

```
docker run -p 8080:8080 -p 50000:50000 -d -v jenkins_home:/var/jenkins_home --name jenkins_master jenkins/jenkins:lts
```

Output:
```
c2b809a66792e713c224694e56a34dc5cbec3d401298173c80961eae48456494
```

4. Get logs of container and extract password:
```
docker logs c2b809a66792e713c224694e56a34dc5cbec3d401298173c80961eae48456494
```

Output:
```
Running from: /usr/share/jenkins/jenkins.war
webroot: /var/jenkins_home/war
2023-12-21 21:11:52.829+0000 [id=1]     INFO    winstone.Logger#logInternal: Beginning extraction from war file
2023-12-21 21:11:53.333+0000 [id=1]     WARNING o.e.j.s.handler.ContextHandler#setContextPath: Empty contextPath
2023-12-21 21:11:53.371+0000 [id=1]     INFO    org.eclipse.jetty.server.Server#doStart: jetty-10.0.18; built: 2023-10-27T01:59:58.245Z; git: 8545fd9bf4cd0d0838f626b405fd4963441546b7; jvm 17.0.9+9
2023-12-21 21:11:53.532+0000 [id=1]     INFO    o.e.j.w.StandardDescriptorProcessor#visitServlet: NO JSP Support for /, did not find org.eclipse.jetty.jsp.JettyJspServlet
2023-12-21 21:11:53.564+0000 [id=1]     INFO    o.e.j.s.s.DefaultSessionIdManager#doStart: Session workerName=node0
2023-12-21 21:11:53.969+0000 [id=1]     INFO    hudson.WebAppMain#contextInitialized: Jenkins home directory: /var/jenkins_home found at: EnvVars.masterEnvVars.get("JENKINS_HOME")
2023-12-21 21:11:54.061+0000 [id=1]     INFO    o.e.j.s.handler.ContextHandler#doStart: Started w.@3e15bb06{Jenkins v2.426.2,/,file:///var/jenkins_home/war/,AVAILABLE}{/var/jenkins_home/war}
2023-12-21 21:11:54.073+0000 [id=1]     INFO    o.e.j.server.AbstractConnector#doStart: Started ServerConnector@6955cb39{HTTP/1.1, (http/1.1)}{0.0.0.0:8080}
2023-12-21 21:11:54.083+0000 [id=1]     INFO    org.eclipse.jetty.server.Server#doStart: Started Server@7c098bb3{STARTING}[10.0.18,sto=0] @1655ms
2023-12-21 21:11:54.084+0000 [id=27]    INFO    winstone.Logger#logInternal: Winstone Servlet Engine running: controlPort=disabled
2023-12-21 21:11:54.248+0000 [id=35]    INFO    jenkins.InitReactorRunner$1#onAttained: Started initialization
2023-12-21 21:11:54.263+0000 [id=55]    INFO    jenkins.InitReactorRunner$1#onAttained: Listed all plugins
2023-12-21 21:11:54.820+0000 [id=38]    INFO    jenkins.InitReactorRunner$1#onAttained: Prepared all plugins
2023-12-21 21:11:54.824+0000 [id=49]    INFO    jenkins.InitReactorRunner$1#onAttained: Started all plugins
2023-12-21 21:11:54.829+0000 [id=49]    INFO    jenkins.InitReactorRunner$1#onAttained: Augmented all extensions
2023-12-21 21:11:54.978+0000 [id=33]    INFO    jenkins.InitReactorRunner$1#onAttained: System config loaded
2023-12-21 21:11:54.979+0000 [id=33]    INFO    jenkins.InitReactorRunner$1#onAttained: System config adapted
2023-12-21 21:11:54.979+0000 [id=46]    INFO    jenkins.InitReactorRunner$1#onAttained: Loaded all jobs
2023-12-21 21:11:54.981+0000 [id=46]    INFO    jenkins.InitReactorRunner$1#onAttained: Configuration for all jobs updated
2023-12-21 21:11:54.998+0000 [id=69]    INFO    hudson.util.Retrier#start: Attempt #1 to do the action check updates server
2023-12-21 21:11:55.339+0000 [id=46]    INFO    jenkins.install.SetupWizard#init:

*************************************************************
*************************************************************
*************************************************************

Jenkins initial setup is required. An admin user has been created and a password generated.
Please use the following password to proceed to installation:

1233dd31883d1238f60d1230ecf8123

This may also be found at: /var/jenkins_home/secrets/initialAdminPassword

*************************************************************
*************************************************************
*************************************************************

2023-12-21 21:12:08.722+0000 [id=53]    INFO    jenkins.InitReactorRunner$1#onAttained: Completed initialization
2023-12-21 21:12:08.737+0000 [id=26]    INFO    hudson.lifecycle.Lifecycle#onReady: Jenkins is fully up and running
2023-12-21 21:12:09.312+0000 [id=69]    INFO    h.m.DownloadService$Downloadable#load: Obtained the updated data file for hudson.tasks.Maven.MavenInstaller
2023-12-21 21:12:09.312+0000 [id=69]    INFO    hudson.util.Retrier#start: Performed the action check updates server successfully at the attempt #1
```

5. Go to localhost:8080 and:
- Login with Administrator password from step 4
- Install Suggested Plugins
- Set URL, [Save and Finish] and [Start using Jenkins]