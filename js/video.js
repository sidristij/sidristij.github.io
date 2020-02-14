(function() {

    if( /Android|webOS|iPhone|iPad|iPod|BlackBerry|IEMobile|Opera Mini/i.test(navigator.userAgent) ) {
  
    } else {
      addVideoSource();
    }
  
    function addVideoSource() {
      const videoPlayer = document.querySelector('.video_bg');
      const videoSrc = videoPlayer.dataset.src;
      const videoNumber = 4;
      var activeVideoNumber = 1;
  
      var webmSource = document.createElement('source');
      webmSource.setAttribute('src', videoSrc + '.webm');
      webmSource.setAttribute('type', 'video/webm');
      videoPlayer.appendChild(webmSource);
  
      var ogvSource = document.createElement('source');
      ogvSource.setAttribute('src', videoSrc + '.ogv');
      ogvSource.setAttribute('type', 'video/ogg');
      videoPlayer.appendChild(ogvSource);
  
      var mpSource = document.createElement('source');
      mpSource.setAttribute('src', videoSrc + '.mp4');
      mpSource.setAttribute('type', 'video/mp4');
      videoPlayer.appendChild(mpSource);
  
      videoPlayer.addEventListener('timeupdate', function() {
        if (this.currentTime > this.duration - 1) {
          videoEnded();
        }
      });
  
      function videoEnded() {
        activeVideoNumber = ++activeVideoNumber % (videoNumber + 1) || 1;
        videoPlayer.src = videoPlayer.currentSrc.replace(/\d(?=(.webm|.ogv|.mp4))/, activeVideoNumber);
        videoPlayer.load();
        videoPlayer.play();
      }
  
      videoPlayer.addEventListener('ended', videoEnded);
    }
  
  }());