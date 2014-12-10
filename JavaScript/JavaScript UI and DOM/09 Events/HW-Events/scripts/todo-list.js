function onAddItemButtonClick() {
    var list = document.getElementById('todo-list'),
        li = document.createElement('li'),
        text = document.getElementById('text-area'),
        deleteBtn;
    li.innerHTML = text.value;
    deleteBtn = document.createElement('button');
    deleteBtn.innerHTML = 'delete';
    deleteBtn.addEventListener('click', onDeleteItemButtonClick, false);
    list.appendChild(li);
    list.appendChild(deleteBtn);
}

function onDeleteItemButtonClick(element) {
    var selectedDeleteBtn = element.target,
        deleteBtnSibling = selectedDeleteBtn.previousSibling;
    selectedDeleteBtn.parentNode.removeChild(selectedDeleteBtn);
    deleteBtnSibling.parentNode.removeChild(deleteBtnSibling);
}

function onShowHideButtonClick() {
    var list = document.getElementById('todo-list');

    if (list.style.visibility) {
        list.style.visibility = '';
    }
    else {
        list.style.visibility = 'hidden';
    }
}

var addButton = document.getElementById('add-button');
addButton.addEventListener('click', onAddItemButtonClick, false);

var showHideBtn = document.getElementById('show-hide');
showHideBtn.addEventListener('click', onShowHideButtonClick, false);
