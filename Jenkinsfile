pipeline {
  agent {
    docker {
      image 'maven:3.3.9-jdk-8'
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