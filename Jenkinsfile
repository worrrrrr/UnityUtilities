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
        sh '''node {
  echo "Test Success"
}'''
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