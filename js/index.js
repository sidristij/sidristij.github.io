window.addEventListener('scroll', () => {
    
    const   header          = document.querySelector('header'),
            matrix          = document.querySelector('.matrix'),
            register        = document.querySelector('.register'),
            headerHeight    = header.offsetHeight

    if (window.scrollY >= headerHeight) {
        header.style.position = 'fixed'
        if (matrix) {
            matrix.style.marginTop = headerHeight + 'px'
        }
        if (register) {
            register.style.marginTop = headerHeight + 'px'
        }
    } else {
        header.style.position = 'relative'
        if (matrix) {
            matrix.style.marginTop = 0
        }
        if (register) {
            register.style.marginTop = 0
        }
    }

})