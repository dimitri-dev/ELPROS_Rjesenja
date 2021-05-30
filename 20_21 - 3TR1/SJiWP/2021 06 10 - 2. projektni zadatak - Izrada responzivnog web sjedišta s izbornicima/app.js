const menu = document.getElementById('menu-toggle');

window.addEventListener('resize', function(event) {
    if (this.window.innerWidth > 768) menu.checked = false;
});