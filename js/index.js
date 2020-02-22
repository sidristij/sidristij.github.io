const   header          = document.querySelector('header'),
        matrix          = document.querySelector('.matrix'),
        headerHeight    = header.offsetHeight;

window.addEventListener('scroll', () => {

    if (!header.classList.contains('fixed')) {
        if (window.scrollY >= headerHeight) {
            header.style.position = 'fixed'
            if (matrix) {
                matrix.style.marginTop = headerHeight + 'px'
            }
        } else {
            header.style.position = 'relative'
            if (matrix) {
                matrix.style.marginTop = 0
            }
        }
    }
});

(function() {

    if( /Android|webOS|iPhone|iPad|iPod|BlackBerry|IEMobile|Opera Mini/i.test(navigator.userAgent) ) {
  
    } else {
      addVideoSource();
      addYoutubeSource();
    }
  
    function addVideoSource() {
      const videoPlayer = document.querySelector('.video_bg');
      const videoSrc = videoPlayer.dataset.src;
      var frame = 0;
    
      var mpSource = document.createElement('source');
      mpSource.setAttribute('src', videoSrc);
      mpSource.setAttribute('type', 'video/mp4');
      videoPlayer.appendChild(mpSource);
  
      videoPlayer.addEventListener('timeupdate', function() {
        if (this.currentTime > this.duration - 1) {
          videoEnded();
        }
        
        if(frame == 0) {
          $('.video_bg').animate({opacity: 1}, 250);
        }
        frame++;
      });
  
      function videoEnded() {
        videoPlayer.src = videoPlayer.currentSrc;
        videoPlayer.load();
        videoPlayer.play();
      }
  
      videoPlayer.addEventListener('ended', videoEnded);
    }

    function addYoutubeSource() {
        const src = ["https://www.youtube.com/embed/hvh4tQzpl0Q","https://www.youtube.com/embed/HiKzuWbRgPM","https://www.youtube.com/embed/_suxE9frTFA"];
        document.querySelector('.video1').src = src[0];
        document.querySelector('.video2').src = src[1];
        document.querySelector('.video3').src = src[2];
    }
  
  })();