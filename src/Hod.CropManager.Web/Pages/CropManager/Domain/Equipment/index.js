$(function () {

    var l = abp.localization.getResource('CropManager');

    var service = cropManager.domain.equipment;
    var createModal = new abp.ModalManager(abp.appPath + 'CropManager/Domain/Equipment/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'CropManager/Domain/Equipment/EditModal');

    var dataTable = $('#EquipmentTable').DataTable(abp.libs.datatables.normalizeConfiguration({
        processing: true,
        serverSide: true,
        paging: true,
        searching: false,
        autoWidth: false,
        scrollCollapse: true,
        order: [[0, "asc"]],
        ajax: abp.libs.datatables.createAjax(service.getList),
        columnDefs: [
            {
                rowAction: {
                    items:
                        [
                            {
                                text: l('Edit'),
                                action: function (data) {
                                    editModal.open({ id: data.record.id });
                                }
                            },
                            {
                                text: l('Delete'),
                                confirmMessage: function (data) {
                                    return l('EquipmentDeletionConfirmationMessage', data.record.id);
                                },
                                action: function (data) {
                                    service.delete(data.record.id)
                                        .then(function () {
                                            abp.notify.info(l('SuccessfullyDeleted'));
                                            dataTable.ajax.reload();
                                        });
                                }
                            }
                        ]
                }
            },
            {
                title: l('EquipmentName'),
                data: "name"
            },
            {
                title: l('EquipmentType'),
                data: "type"
            },
        ]
    }));

    createModal.onResult(function () {
        dataTable.ajax.reload();
    });

    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $('#NewEquipmentButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});
