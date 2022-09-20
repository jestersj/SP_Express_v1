const tl = gsap.timeline();
const pl = gsap.timeline();
const train = gsap.timeline();
const ship = gsap.timeline();
const smallShip = gsap.timeline();


tl.fromTo('.truck', {xPercent: 180}, {xPercent:-50})

pl.fromTo('.plane', {xPercent: -50}, {xPercent: 150, yPercent: -300})

train.fromTo('.train', {xPercent: 100}, {xPercent:-50})

ship.fromTo('.ship', {xPercent: -80}, {xPercent: 20})
smallShip.fromTo('.small_ship', {xPercent: 100}, {xPercent: -90})

ScrollTrigger.create({
    animation: tl,
    trigger: '.pic_truck',
    scrub: true,
    pin: false,
    start: 'top top',
    end: 'bottom top',
})

ScrollTrigger.create({
    animation: pl,
    trigger: '.pic_plane',
    scrub: true,
    pin: false,
    start: 'top top',
    end: 'bottom top'
})
ScrollTrigger.create({
    animation: train,
    trigger: '.pic_train',
    scrub: true,
    pin: false,
    start: 'top top',
    end: 'bottom top'
})
ScrollTrigger.create({
    animation: ship,
    trigger: '.pic_ship',
    scrub: true,
    pin: false,
    start: 'top top',
    end: 'bottom top'
})
ScrollTrigger.create({
    animation: smallShip,
    trigger: '.pic_ship',
    scrub: true,
    pin: false,
    start: 'top top',
    end: 'bottom top'
})