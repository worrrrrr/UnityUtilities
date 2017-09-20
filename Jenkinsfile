pipeline {
  agent {
    docker {
      image 'node:alpine'
    }
    
  }
  stages {
    stage('Initialize') {
      steps {
        echo 'Start building UnityUtilities'
        tool 'Sonarqube'
        sh '''script{
                def scannerHome = tool 'Sonarqube';
                withSonarQubeEnv('SonarQube') {
                    sh "${scannerHome}/bin/sonar-scanner"
                    }    
                }'''
        }
      }
      stage('Test') {
        steps {
          echo 'Testing'
          sh 'pwd'
        }
      }
      stage('Build') {
        steps {
          echo 'Building'
        }
      }
      stage('Deploy') {
        steps {
          echo 'Success'
        }
      }
    }
  }