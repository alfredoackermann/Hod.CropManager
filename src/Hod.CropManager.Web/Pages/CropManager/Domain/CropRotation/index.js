$(function () {

    var l = abp.localization.getResource('CropManager');

    var service = cropManager.domain.cropRotation;
    var createModal = new abp.ModalManager(abp.appPath + 'CropManager/Domain/CropRotation/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'CropManager/Domain/CropRotation/EditModal');

    var dataTable = $('#CropRotationTable').DataTable(abp.libs.datatables.normalizeConfiguration({
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
                                    return l('CropRotationDeletionConfirmationMessage', data.record.id);
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
                title: l('CropRotationField'),
                data: "field"
            },
            {
                title: l('CropRotationFieldId'),
                data: "fieldId"
            },
            {
                title: l('CropRotationCropType'),
                data: "cropType"
            },
            {
                title: l('CropRotationCropTypeId'),
                data: "cropTypeId"
            },
            {
                title: l('CropRotationRotationOrder'),
                data: "rotationOrder"
            },
            {
                title: l('CropRotationStartDate'),
                data: "startDate"
            },
            {
                title: l('CropRotationEndDate'),
                data: "endDate"
            },
            {
                title: l('CropRotationNotes'),
                data: "notes"
            },
        ]
    }));

    createModal.onResult(function () {
        dataTable.ajax.reload();
    });

    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $('#NewCropRotationButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});
