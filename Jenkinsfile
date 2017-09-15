pipeline {
  agent {
    docker {
      image 'node'
    }
    
  }
  stages {
    stage('Initialize') {
      steps {
        echo 'Start building UnityUtilities'
        sh 'mvn clean'
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