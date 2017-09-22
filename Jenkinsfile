pipeline {
  agent none
  stages {
    stage('Initialize') {
      steps {
        echo 'Start building UnityUtilities'
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