const form = document.querySelector('#note-form');
const input = document.querySelector('#note-input');
const notesList = document.querySelector('#notes');

form.addEventListener('submit', addNote);

function addNote(e) {
    e.preventDefault();

    if (input.value === '') {
        alert('Please enter a note.');
    } else {
        const li = document.createElement('li');
        li.textContent = input.value;

        const removeButton = document.createElement('button');
        removeButton.textContent = 'Remove';
        removeButton.className = 'remove-button';
        removeButton.addEventListener('click', removeNote);

        li.appendChild(removeButton);
        notesList.appendChild(li);
        input.value = '';
    }
}

function removeNote(e) {
    const button = e.target;
    const li = button.parentNode;
    notesList.removeChild(li);
}

