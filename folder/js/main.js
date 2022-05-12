let boxes=document.querySelectorAll('.box-1');
let basket=document.querySelector('.basket');

boxes.forEach(box =>{
    box.addEventListener("dragstart",function(e){
        e.dataTransfer.setData("img",this.img);
    });
});
basket.addEventListener('dragover',function(e){
    e.preventDefault();
});
basket.ondrop=(e)=>{
    basket.img=e.dataTransfer.getData('img');
}