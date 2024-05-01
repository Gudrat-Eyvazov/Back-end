
  const nav = document.querySelector('.travelomnia__header__container > .pure-css-nav');
  window.addEventListener('resize', (e) => {
      if (e.target.innerWidth < 1024) {
          nav.classList.add('nav-vertical');
      } else {
          nav.classList.remove('nav-vertical');
      }
  });

  window.addEventListener('DOMContentLoaded', () => {
      if (window.innerWidth < 1024) {
          nav.classList.add('nav-vertical');
      } else {
          nav.classList.remove('nav-vertical');
      }
  });

  const burger = document.querySelector('.menu-burger');
  const burgerNItems = document.querySelectorAll('.menu-burger');
  burgerNItems.forEach(element => {
      element.addEventListener('click', () => {
          document.querySelectorAll('.menu-bg, .menu-items, .menu-burger').forEach(elem => {
              elem.classList.toggle('fs');
          });
          burger.textContent === '☰' ? burger.textContent = '✕' : burger.textContent = '☰';
      });
  });