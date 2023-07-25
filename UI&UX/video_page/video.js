let videolist=document.querySelectorAll('.video-list-container .list');

videolist.forEach(vid=>{
    vid.onclick=()=>{
        let src=vid.querySelector('.list-video').src;
        let title=vid.querySelector('.list-title').innerHTML;
        document.querySelector('.main-video-conatiner .main-video').src=src;
        document.querySelector('.main-video-container .main-video').play();
        document.querySelector('.main-video-container .main-vid-title').innerHTML=title;
    };
});