function confirmDelete(UniqueId, isDeleteClicked) {
    var deleteSpan = 'deleteSpan_' + UniqueId;
    var confirmDeleteSpan = 'confirmDeleteSpan_' + UniqueId;
    if (isDeleteClicked) {
        $('#' + deleteSpan).hide();
        $('#' + confirmDeleteSpan).show();
    } else {
        $('#' + deleteSpan).show();
        $('#' + confirmDeleteSpan).hide();
    }

}