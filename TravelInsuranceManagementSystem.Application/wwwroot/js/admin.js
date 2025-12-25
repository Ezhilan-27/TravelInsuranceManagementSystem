
(function () {
    const path = location.pathname.toLowerCase();
    document.querySelectorAll('.nav-item').forEach(a => {
        const href = a.getAttribute('href')?.toLowerCase() || '';
        if (path.includes(href.toLowerCase())) {
            a.style.background = 'var(--gray)';
        }
    });
})();
