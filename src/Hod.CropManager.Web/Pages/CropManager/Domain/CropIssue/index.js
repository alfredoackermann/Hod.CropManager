$(function () {

    var l = abp.localization.getResource('CropManager');

    var service = cropManager.domain.cropIssue;
    var createModal = new abp.ModalManager(abp.appPath + 'CropManager/Domain/CropIssue/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'CropManager/Domain/CropIssue/EditModal');

    var dataTable = $('#CropIssueTable').DataTable(abp.libs.datatables.normalizeConfiguration({
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
                                    return l('CropIssueDeletionConfirmationMessage', data.record.id);
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
                title: l('CropIssueCrop'),
                data: "crop"
            },
            {
                title: l('CropIssueCropId'),
                data: "cropId"
            },
            {
                title: l('CropIssueIssueType'),
                data: "issueType"
            },
            {
                title: l('CropIssueIssueTypeId'),
                data: "issueTypeId"
            },
            {
                title: l('CropIssueNotes'),
                data: "notes"
            },
            {
                title: l('CropIssueDate'),
                data: "date"
            },
        ]
    }));

    createModal.onResult(function () {
        dataTable.ajax.reload();
    });

    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $('#NewCropIssueButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});
