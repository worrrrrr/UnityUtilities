pipeline {
  agent any
  stages {
    stage('Initialize') {
      steps {
        parallel(
          "Initialize": {
            echo 'Add minimal Pipeline'
            sh 'echo "Hello World"'
            
          },
          "Path": {
            sh 'echo PATH = ${PATH}'
            
          }
        )
      }
    }
    stage('Install') {
      steps {
        sh 'echo PATH = ${PATH}'
      }
    }
  }
}