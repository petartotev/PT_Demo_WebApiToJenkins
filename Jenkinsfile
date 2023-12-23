#!Groovy

pipeline {
    agent any

    stages {
        stage("build") {
            steps {
                echo 'Building it...'
                // Install the .NET SDK
                sh 'curl -LO https://packages.microsoft.com/config/ubuntu/20.04/packages-microsoft-prod.deb'
                sh 'dpkg -i packages-microsoft-prod.deb'
                sh 'apt-get update'
                sh 'apt-get install -y apt-transport-https'
                sh 'apt-get update'
                sh 'apt-get install -y dotnet-sdk-6.0'
            }
        }

        stage("test") {
            steps {
                echo 'Testing it...'
                script {
                    // Change directory to the test project
                    dir('./src/WebApiToJenkins.Tests') {
                        // Run NUnit tests using dotnet test
                        sh 'dotnet test'
                    }
                }
            }
        }

        stage("deploy") {
            steps {
                echo 'Deploying it...'
            }
        }
    }
}