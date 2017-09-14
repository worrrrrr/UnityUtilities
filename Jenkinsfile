pipeline {
  agent {
    docker {
      image 'node:latest'
    }
    
  }
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