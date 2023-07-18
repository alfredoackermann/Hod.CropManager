$(function () {

    var l = abp.localization.getResource('CropManager');

    var service = cropManager.domain.irrigationSystem;
    var createModal = new abp.ModalManager(abp.appPath + 'CropManager/Domain/IrrigationSystem/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'CropManager/Domain/IrrigationSystem/EditModal');

    var dataTable = $('#IrrigationSystemTable').DataTable(abp.libs.datatables.normalizeConfiguration({
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
                                    return l('IrrigationSystemDeletionConfirmationMessage', data.record.id);
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
                title: l('IrrigationSystemName'),
                data: "name"
            },
            {
                title: l('IrrigationSystemType'),
                data: "type"
            },
            {
                title: l('IrrigationSystemField'),
                data: "field"
            },
            {
                title: l('IrrigationSystemFieldId'),
                data: "fieldId"
            },
        ]
    }));

    createModal.onResult(function () {
        dataTable.ajax.reload();
    });

    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $('#NewIrrigationSystemButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});
