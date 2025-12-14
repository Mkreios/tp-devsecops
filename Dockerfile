FROM tomcat:9.0-jdk11
COPY target/maven-web-application.jar /usr/local/tomcat/webapps/maven-web-application.jar
EXPOSE 8080
ENTRYPOINT ["java","-jar","/app.jar"]