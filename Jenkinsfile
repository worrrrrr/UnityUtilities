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
        sh '''node --version
 '''
        tool 'recent node'
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