
async function loadDataTable(url) {
    try {
        const resp = await fetch(url);
        const data = await resp.json();
        $('#tblData').DataTable({
            data: data.data,
            columns: [
                { data: "name", "width": "15%" },
                { data: "documentation", "width": "15%" },
                { data: "startDate", "width": "15%" },
                { data: "endDate", "width": "15%" },
            ],
        });
    } catch (error) {
        console.error(error);
    }
};

loadDataTable(`https://localhost:44300/Admin/Freelancer/project/${freelancerId}`);
