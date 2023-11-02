// git repository info
    def gitRepository = 'https://github.com/longkunz/acme_bookstore.git'
    def gitBranch = 'master'

// Image infor in registry
    def imageGroup = 'longkunz'
    def appName = "acme.bookstore"

// Build version
def version = "develop-1.0.0.${BUILD_NUMBER}"
def dockerFilePath = '-f host/Acme.BookStore.HttpApi.Host/Dockerfile .'

pipeline {
    agent any
    
        stages {
                stage('Checkout') {
                    steps {
                        // Git clone repository
                        checkout([$class: 'GitSCM', 
                        branches: [[name: gitBranch]], 
                        userRemoteConfigs: [[url: gitRepository]]])
                    }
                }
                
                stage('Build Docker Image') {
                    steps {
                        script {
                            dockerImageName = "${imageGroup}/${appName}:${version}"
                            dockerImage = docker.build(dockerImageName, dockerFilePath)
                        }
                    }
                }
                
                stage('Push Docker Image to Docker Hub') {
                    steps {
                        script {
                            withDockerRegistry([ credentialsId: "docker-hub", url: "" ]) 
                            {
                                dockerImage.push(version)
                            }
                        }
                    }
                }
            }
        }
