$(function () {

    var l = abp.localization.getResource('CropManager');

    var service = cropManager.domain.field;
    var createModal = new abp.ModalManager(abp.appPath + 'CropManager/Domain/Field/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'CropManager/Domain/Field/EditModal');

    var dataTable = $('#FieldTable').DataTable(abp.libs.datatables.normalizeConfiguration({
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
                                    return l('FieldDeletionConfirmationMessage', data.record.id);
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
                title: l('FieldName'),
                data: "name"
            },
            {
                title: l('FieldSize'),
                data: "size"
            },
            {
                title: l('FieldSoilType'),
                data: "soilType"
            },
            {
                title: l('FieldLocation'),
                data: "location"
            },
            {
                title: l('FieldIrrigationSystems'),
                data: "irrigationSystems"
            },
            {
                title: l('FieldCropRotations'),
                data: "cropRotations"
            },
            {
                title: l('FieldCrops'),
                data: "crops"
            },
        ]
    }));

    createModal.onResult(function () {
        dataTable.ajax.reload();
    });

    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $('#NewFieldButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});
