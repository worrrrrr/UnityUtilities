pipeline {
  agent any
  stages {
    stage('Initialize') {
      steps {
        echo 'Add minimal Pipeline'
        sh 'echo "Hello World"'
      }
    }
    stage('Install') {
      steps {
        sh 'echo PATH = ${PATH}'
      }
    }
  }
}