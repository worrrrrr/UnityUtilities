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
        echo 'Testing'
        sh 'npm --version'
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