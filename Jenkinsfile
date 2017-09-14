pipeline {
  agent any
  stages {
    stage('Initialize') {
      steps {
        parallel(
          "Initialize": {
            echo 'Add minimal Pipeline'
            
          },
          "Path": {
            sh 'echo PATH = ${PATH}'
            
          }
        )
      }
    }
  }
}