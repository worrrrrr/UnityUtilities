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
      }
    }
    stage('Test') {
      steps {
        sh 'java -version'
        sh '''echo PATH = ${PATH}
'''
      }
    }
    stage('Build') {
      steps {
        echo 'Building..'
      }
    }
    stage('Deploy') {
      steps {
        echo 'Success'
      }
    }
  }
}