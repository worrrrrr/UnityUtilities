pipeline {
  agent {
    docker {
      image 'node'
    }
    
  }
  stages {
    stage('Initialize') {
      steps {
        parallel(
          "Initialize": {
            echo 'Add minimal Pipeline'
            sh 'npm install'
            
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