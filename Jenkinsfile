pipeline {
  agent any
  stages {
    stage('Initialize') {
      steps {
        echo 'Start building UnityUtilities'
      }
    }
    stage('Test') {
      steps {
        sh 'java --version'
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