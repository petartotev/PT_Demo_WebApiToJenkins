#!Groovy

pipeline {
    agent {
        docker {
            image 'mcr.microsoft.com/dotnet/sdk:6.0'
        }
    }

    stages {
        stage("build") {
            steps {
                echo 'Building it...'
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