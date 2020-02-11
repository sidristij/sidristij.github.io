const   header          = document.querySelector('header'),
        matrix          = document.querySelector('.matrix'),
        headerHeight    = header.offsetHeight

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
   

})

if (screen.width < 991) {
  //  header.classList.add('fixed')
  //  header.nextElementSibling.style.marginTop = headerHeight + 'px'
}