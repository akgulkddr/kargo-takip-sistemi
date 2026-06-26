html {
    font-size: 16px;
    min-height: 100%;
}

body {
    margin: 0;
    background: linear-gradient(to bottom, #eef2f7, #dde5ee) !important;
    font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
    color: #111827;
}

/* Header */
.yk-header {
    background: #dde5ee;
    box-shadow: 0 8px 24px rgba(0,0,0,0.06);
}

.yk-container {
    max-width: 1500px;
    margin: auto;
    padding: 0 52px;
}

.yk-topbar {
    height: 58px;
    background: #dde5ee;
}

.yk-topbar-inner {
    height: 58px;
    display: flex;
    align-items: center;
    justify-content: space-between;
}

.yk-language-dropdown {
    position: relative;
}

.yk-language-btn {
    border: none;
    background: white;
    padding: 10px 16px;
    border-radius: 6px;
    box-shadow: 0 6px 18px rgba(0,0,0,0.08);
    font-weight: 600;
    color: #344054;
}

.yk-language-menu {
    display: none;
    position: absolute;
    top: 48px;
    left: 0;
    width: 150px;
    background: white;
    border-radius: 0 0 8px 8px;
    box-shadow: 0 12px 24px rgba(0,0,0,0.12);
    z-index: 20;
    overflow: hidden;
}

    .yk-language-menu.show {
        display: block;
    }

    .yk-language-menu a {
        display: block;
        padding: 13px 18px;
        text-decoration: none;
        color: #344054;
        font-size: 15px;
    }

        .yk-language-menu a:hover {
            background: #fff3e6;
            color: #ee7d00;
        }

.yk-social {
    display: flex;
    gap: 18px;
    color: #ee7d00;
    font-weight: 800;
}

.yk-mainbar {
    background: #dde5ee;
    
}

.yk-main-content {
    min-height: 110px;
    display: flex;
    align-items: center;
    gap: 32px;
}

.yk-logo {
    display: flex;
    align-items: center;
    text-decoration: none;
}

.yk-logo-box {
    background: #183b73;
    color: white;
    padding: 16px 26px;
    border-radius: 22px;
    font-size: 26px;
    font-weight: 900;
    letter-spacing: 0.5px;
    box-shadow: 0 10px 24px rgba(24,59,115,0.25);
    display: flex;
    align-items: center;
    gap: 12px;
    white-space: nowrap;
}

.yk-logo-icon {
    font-size: 28px;
}

.yk-logo-text {
    display: inline-block;
}

.yk-nav {
    display: flex;
    align-items: center;
    gap: 42px;
    flex: 1;
    margin-left: 35px;
}

    .yk-nav a {
        text-decoration: none;
        color: #111827;
        font-size: 17px;
        font-weight: 600;
    }

        .yk-nav a:hover {
            color: #ee7d00;
        }

.yk-actions {
    display: flex;
    align-items: center;
    gap: 16px;
    margin-left: auto;
}

    .yk-actions form {
        margin: 0;
    }

    .yk-actions input {
        width: 260px !important;
    }
    .yk-actions input {
        width: 200px;
        height: 50px;
        border: 1px solid #d8dce3;
        border-radius: 28px;
        padding: 0 20px;
        font-size: 16px;
        outline: none;
    }

.yk-contact {
    background: #f1f3f5;
    color: #006fd6;
    text-decoration: none;
    padding: 15px 22px;
    border-radius: 28px;
    font-weight: 800;
}

.yk-login {
    background: #f58200;
    color: white;
    text-decoration: none;
    padding: 15px 24px;
    border-radius: 28px;
    font-weight: 800;
}

/* Genel sayfa */
.page-title {
    font-weight: 800;
    color: #183b73;
}

.content-card {
    background-color: white;
    padding: 25px;
    border-radius: 16px;
    box-shadow: 0 6px 18px rgba(0,0,0,0.08);
}

.table {
    background-color: white;
    border-radius: 12px;
    overflow: hidden;
}

    .table thead {
        background-color: #183b73;
        color: white;
    }

.btn {
    border-radius: 8px;
}

.btn-primary {
    background-color: #183b73;
    border-color: #183b73;
}

    .btn-primary:hover {
        background-color: #2a5298;
        border-color: #2a5298;
    }

/* Ana sayfa */
.dashboard-card {
    border: none;
    border-radius: 16px;
    color: white;
    padding: 25px;
    min-height: 190px;
    box-shadow: 0 8px 20px rgba(0,0,0,0.12);
    transition: transform 0.3s ease;
}

    .dashboard-card:hover {
        transform: translateY(-5px);
    }

.dashboard-icon {
    font-size: 34px;
    margin-bottom: 12px;
}

.dashboard-number {
    font-size: 2.3rem;
    font-weight: bold;
}

.card-blue {
    background: linear-gradient(135deg, #007bff, #0056b3);
}

.card-green {
    background: linear-gradient(135deg, #28a745, #1e7e34);
}

.card-orange {
    background: linear-gradient(135deg, #fd7e14, #d35400);
}

.card-purple {
    background: linear-gradient(135deg, #6f42c1, #4b2c91);
}

.tracking-home-card {
    margin-bottom: 40px;
}

.tracking-home-info {
    display: flex;
    align-items: center;
    gap: 22px;
}

.tracking-home-icon {
    width: 110px;
    height: 110px;
    min-width: 110px;
    border-radius: 50%;
    background: #fff0df;
    color: #f58200;
    display: flex;
    align-items: center;
    justify-content: center;
    font-size: 52px;
}

.tracking-home-info h4 {
    font-size: 28px;
    font-weight: 800;
    color: #183b73;
    margin-bottom: 8px;
}

.tracking-home-info p {
    color: #6c757d;
    margin: 0;
}

.tracking-note {
    background: #fff4e8;
    color: #6c757d;
    padding: 13px 16px;
    border-radius: 10px;
    font-size: 15px;
}

.status-badge {
    padding: 9px 14px;
    border-radius: 20px;
    font-size: 13px;
    font-weight: 700;
}

/* Footer */
.yk-footer {
    text-align: center;
    padding: 28px;
    color: #667085;
    border-top: 1px solid #d8dce3;
    background: #dde5ee;
    font-size: 16px;
    margin-top: 40px;
}

@media (max-width: 900px) {
    .yk-main-content {
        flex-direction: column;
        align-items: flex-start;
        padding: 20px 52px;
    }

    .yk-nav,
    .yk-actions {
        flex-wrap: wrap;
    }
}
.tracking-detail-box {
    background: #f8fafc;
    border: 1px solid #eef1f5;
    border-radius: 10px;
    padding: 14px 16px;
    height: 100%;
}

    .tracking-detail-box span,
    .route-box span {
        display: block;
        color: #6b7280;
        font-size: 12px;
        margin-bottom: 4px;
        font-weight: 600;
    }

    .tracking-detail-box strong,
    .route-box strong {
        color: #183b73;
        font-size: 15px;
        font-weight: 700;
    }

.route-box {
    background: #fff8f1;
    border: 1px solid #ffe0b8;
    border-radius: 12px;
    padding: 16px 20px;
    display: flex;
    align-items: center;
    justify-content: space-between;
}

.route-arrow {
    font-size: 24px;
    font-weight: 700;
    color: #f58200;
}

.tracking-timeline {
    margin-top: 10px;
}

.timeline-item {
    display: flex;
    gap: 12px;
    margin-bottom: 14px;
}

.timeline-dot {
    width: 12px;
    height: 12px;
    min-width: 12px;
    border-radius: 50%;
    background: #f58200;
    margin-top: 10px;
}

.timeline-content {
    background: #f8fafc;
    border: 1px solid #eef1f5;
    border-left: 3px solid #183b73;
    border-radius: 10px;
    padding: 12px 14px;
    flex: 1;
}

    .timeline-content p {
        margin-top: 10px !important;
        margin-bottom: 6px !important;
        font-size: 14px;
    }
.cargo-result-header {
    border-bottom: 1px solid #eef1f5;
    padding-bottom: 20px;
    margin-bottom: 25px;
}

.cargo-status-pill {
    display: inline-block;
    background: #fff4e8;
    color: #f58200;
    padding: 8px 16px;
    border-radius: 999px;
    font-weight: 800;
    margin-bottom: 14px;
}

.cargo-result-header h3 {
    font-size: 26px;
    font-weight: 800;
    color: #111827;
    margin-bottom: 8px;
}

.cargo-progress-area {
    position: relative;
    padding: 20px 0 5px;
}

.cargo-progress-line {
    height: 8px;
    background: #f58200;
    border-radius: 999px;
    width: 100%;
}

.cargo-progress-dot {
    width: 28px;
    height: 28px;
    border-radius: 50%;
    background: white;
    border: 8px solid #f58200;
    position: absolute;
    right: 0;
    top: 10px;
}

.cargo-progress-text {
    text-align: right;
    margin-top: 14px;
    color: #6c757d;
    font-weight: 600;
}

.cargo-history-list {
    margin-top: 20px;
    position: relative;
}

.cargo-history-item {
    display: flex;
    gap: 18px;
    position: relative;
    padding-bottom: 28px;
}

    .cargo-history-item:not(:last-child)::before {
        content: "";
        position: absolute;
        left: 13px;
        top: 28px;
        width: 3px;
        height: calc(100% - 18px);
        background: #d8dce3;
    }

    .cargo-history-item.current:not(:last-child)::before {
        background: #f58200;
    }

.cargo-history-marker {
    width: 30px;
    height: 30px;
    min-width: 30px;
    border-radius: 50%;
    background: #98a2b3;
    color: white;
    display: flex;
    align-items: center;
    justify-content: center;
    font-size: 13px;
    font-weight: 800;
    z-index: 2;
    box-shadow: 0 0 0 5px #f4f7fb;
}

.cargo-history-item.current .cargo-history-marker {
    background: #f58200;
}

.cargo-history-content {
    background: #ffffff;
    border: 1px solid #eef1f5;
    border-radius: 14px;
    padding: 14px 18px;
    flex: 1;
    box-shadow: 0 6px 18px rgba(0,0,0,0.05);
}

    .cargo-history-content h5 {
        color: #667085;
        font-weight: 800;
        margin-bottom: 6px;
    }

.cargo-history-item.current .cargo-history-content {
    background: #fff8f1;
    border-color: #ffd8ad;
}

    .cargo-history-item.current .cargo-history-content h5 {
        color: #f58200;
    }

.history-main-text {
    font-size: 16px;
    font-weight: 700;
    margin-bottom: 5px;
    color: #111827;
}

.cargo-history-content span {
    color: #6c757d;
    font-size: 14px;
}

.cargo-route-card {
    border: 1px solid #eef1f5;
    border-radius: 16px;
    padding: 22px;
    background: #f8fafc;
}

.route-point {
    display: flex;
    align-items: center;
    gap: 16px;
}

.route-icon {
    width: 28px;
    height: 28px;
    border-radius: 50%;
}

    .route-icon.start {
        border: 8px solid #344054;
    }

    .route-icon.end {
        background: #f58200;
        position: relative;
    }

        .route-icon.end::after {
            content: "";
            width: 8px;
            height: 8px;
            background: white;
            border-radius: 50%;
            position: absolute;
            top: 10px;
            left: 10px;
        }

.route-divider {
    width: 2px;
    height: 34px;
    background: #d8dce3;
    margin-left: 13px;
}

.route-point span,
.cargo-detail-grid span {
    display: block;
    color: #6c757d;
    font-size: 14px;
    margin-bottom: 4px;
}

.route-point strong,
.cargo-detail-grid strong {
    color: #111827;
    font-size: 17px;
}

.cargo-detail-grid {
    display: grid;
    grid-template-columns: repeat(3, 1fr);
    gap: 18px;
}

    .cargo-detail-grid div {
        background: #f8fafc;
        border: 1px solid #eef1f5;
        border-radius: 12px;
        padding: 16px;
    }

@media (max-width: 768px) {
    .cargo-detail-grid {
        grid-template-columns: 1fr;
    }
}
.shipment-timeline {
    position: relative;
    padding-left: 8px;
}

.shipment-step {
    position: relative;
    display: flex;
    gap: 18px;
    padding-bottom: 28px;
}

    .shipment-step:not(:last-child)::before {
        content: "";
        position: absolute;
        left: 13px;
        top: 30px;
        width: 2px;
        height: calc(100% - 10px);
        background: #d8dce3;
    }

    .shipment-step.active:not(:last-child)::before {
        background: #f58200;
    }

.shipment-step-icon {
    width: 28px;
    height: 28px;
    min-width: 28px;
    border-radius: 50%;
    background: #8a8f98;
    color: white;
    display: flex;
    align-items: center;
    justify-content: center;
    font-size: 12px;
    font-weight: 800;
    z-index: 2;
}

.shipment-step.active .shipment-step-icon {
    background: #f58200;
    box-shadow: 0 0 0 6px #fff4e8;
}

.shipment-step-content {
    padding-top: 1px;
}

    .shipment-step-content h5 {
        margin: 0 0 6px;
        font-size: 18px;
        font-weight: 800;
        color: #6c757d;
    }

.shipment-step.active .shipment-step-content h5 {
    color: #f58200;
}

.shipment-step-content p {
    margin: 0 0 5px;
    font-size: 17px;
    font-weight: 700;
    color: #111827;
}

.shipment-step-content span {
    color: #6c757d;
    font-size: 14px;
}
.detail-header-box {
    background: linear-gradient(135deg, #f8fafc, #ffffff);
    border: 1px solid #eef1f5;
    border-radius: 20px;
    padding: 24px 28px;
    position: relative;
    overflow: hidden;
    box-shadow: 0 8px 22px rgba(0,0,0,0.05);
}

    .detail-header-box::before {
        content: "";
        position: absolute;
        left: 0;
        top: 0;
        width: 7px;
        height: 100%;
        background: #183b73;
    }

.detail-status-label {
    display: inline-block;
    background: #eef4ff;
    color: #183b73;
    padding: 8px 15px;
    border-radius: 999px;
    font-size: 13px;
    font-weight: 900;
    margin-bottom: 12px;
}

.detail-header-box h4 {
    color: #183b73;
    font-weight: 900;
    margin-bottom: 8px;
}

.detail-header-box p {
    color: #667085;
    margin: 0;
}

.detail-status-label {
    display: inline-block;
    background: #f58200;
    color: white;
    padding: 7px 14px;
    border-radius: 20px;
    font-size: 13px;
    font-weight: 800;
    margin-bottom: 12px;
}

.detail-header-box h4 {
    color: #183b73;
    font-weight: 900;
    margin-bottom: 8px;
}

.detail-header-box p {
    color: #6c757d;
    margin: 0;
}
.delete-header-box {
    background: linear-gradient(135deg, #fff1f1, #ffffff);
    border: 1px solid #ffc9c9;
    border-left: 6px solid #dc3545;
}

.delete-label {
    background: #dc3545 !important;
}
.horizontal-timeline {
    display: flex;
    justify-content: space-between;
    align-items: flex-start;
    position: relative;
    margin-top: 30px;
    padding: 20px 0 5px;
}

    .horizontal-timeline::before {
        content: "";
        position: absolute;
        top: 34px;
        left: 8%;
        right: 8%;
        height: 4px;
        background: #d8dce3;
        border-radius: 20px;
        z-index: 1;
    }
    .horizontal-timeline::after {
        content: "";
        position: absolute;
        top: 34px;
        left: 8%;
        width: var(--progress);
        height: 4px;
        background: #f58200;
        border-radius: 20px;
        z-index: 1;
    }

.timeline-step {
    position: relative;
    z-index: 2;
    width: 16%;
    text-align: center;
}

.timeline-dot-horizontal {
    width: 28px;
    height: 28px;
    background: white;
    border: 5px solid #d8dce3;
    border-radius: 50%;
    margin: 0 auto 12px;
}

.timeline-step.active .timeline-dot-horizontal {
    border-color: #f58200;
    background: #f58200;
    box-shadow: 0 0 0 6px #fff4e8;
}

.timeline-step span {
    display: block;
    font-size: 13px;
    font-weight: 700;
    color: #6c757d;
}

.timeline-step.active span {
    color: #183b73;
}
.soft-badge {
    background: #eef4ff;
    color: #2d6cdf;
    padding: 9px 15px;
    border-radius: 30px;
    font-size: 13px;
    font-weight: 800;
    box-shadow: 0 4px 10px rgba(45,108,223,0.12);
}

.durum-pill {
    padding: 9px 15px;
    border-radius: 30px;
    font-size: 13px;
    font-weight: 700;
    display: inline-block;
}

/* Yeþil */
.durum-green {
    background: #edf9f1;
    color: #1f9254;
    box-shadow: 0 4px 10px rgba(31,146,84,0.12);
}

/* Mavi */
.durum-blue {
    background: #eef4ff;
    color: #2d6cdf;
    box-shadow: 0 4px 10px rgba(45,108,223,0.12);
}

/* Turuncu */
.durum-orange {
    background: #fff4e8;
    color: #f58200;
    box-shadow: 0 4px 10px rgba(245,130,0,0.12);
}

/* Gri */
.durum-default {
    background: #f2f4f7;
    color: #475467;
    box-shadow: 0 4px 10px rgba(0,0,0,0.05);
}
.soft-action-btn {
    display: inline-block;
    text-decoration: none;
    padding: 8px 13px;
    border-radius: 20px;
    font-size: 13px;
    font-weight: 800;
    margin-left: 6px;
    transition: all 0.25s ease;
}

    .soft-action-btn:hover {
        transform: translateY(-2px);
        text-decoration: none;
    }

    
.form-select {
    height: 48px;
    border: 1px solid #d8dce3;
    border-radius: 14px;
    padding: 0 16px;
    font-size: 15px;
    font-weight: 600;
    color: #344054;
    background-color: #ffffff;
    box-shadow: 0 4px 12px rgba(0,0,0,0.04);
    transition: all 0.25s ease;
}

    .form-select:hover {
        border-color: #f58200;
    }

    .form-select:focus {
        border-color: #f58200;
        box-shadow: 0 0 0 0.18rem rgba(245,130,0,0.16);
    }

.form-label {
    font-weight: 700;
    color: #183b73;
    margin-bottom: 8px;
}

.soft-action-btn,
a.soft-action-btn,
button.soft-action-btn {
    display: inline-flex !important;
    align-items: center !important;
    justify-content: center !important;
    text-decoration: none !important;
    padding: 10px 18px !important;
    border-radius: 24px !important;
    font-size: 14px !important;
    font-weight: 800 !important;
    min-height: 42px !important;
    min-width: 105px !important;
    margin-left: 6px !important;
    border: none !important;
    transition: all 0.25s ease !important;
}

    


    .soft-action-btn:hover {
        transform: translateY(-2px) !important;
        text-decoration: none !important;
    }


.form-control,
.form-select {
    height: 50px !important;
    border: 1px solid #d8dce3 !important;
    border-radius: 14px !important;
    padding: 0 18px !important;
    font-size: 15px !important;
    font-weight: 600 !important;
    color: #344054 !important;
    background-color: #ffffff !important;
    box-shadow: 0 4px 12px rgba(0,0,0,0.05) !important;
    transition: all 0.25s ease !important;
}

    .form-control:hover,
    .form-select:hover {
        border-color: #f58200 !important;
    }

    .form-control:focus,
    .form-select:focus {
        border-color: #f58200 !important;
        box-shadow: 0 0 0 0.2rem rgba(245,130,0,0.15) !important;
    }

textarea.form-control {
    min-height: 120px !important;
    padding-top: 14px !important;
}

/* TEK TÝP BUTON SÝSTEMÝ - SON KURAL */
.soft-action-btn,
a.soft-action-btn,
button.soft-action-btn,
.soft-action-btn.edit,
.soft-action-btn.detail,
.soft-action-btn.add-btn,
.soft-action-btn.back-btn,
a.soft-action-btn.edit,
a.soft-action-btn.detail,
a.soft-action-btn.add-btn,
a.soft-action-btn.back-btn,
button.soft-action-btn.edit,
button.soft-action-btn.detail,
button.soft-action-btn.add-btn,
button.soft-action-btn.back-btn {
    background: #183b73 !important;
    color: white !important;
    box-shadow: 0 6px 14px rgba(24,59,115,0.22) !important;
    padding: 10px 18px !important;
    border-radius: 24px !important;
    font-size: 14px !important;
    font-weight: 800 !important;
    min-height: 42px !important;
    min-width: 105px !important;
    border: none !important;
    text-decoration: none !important;
}

    .soft-action-btn:hover,
    a.soft-action-btn:hover,
    button.soft-action-btn:hover {
        background: #244b8f !important;
        color: white !important;
        transform: translateY(-2px) !important;
        text-decoration: none !important;
    }

    /* Sadece silme butonu kýrmýzý kalsýn */
    .soft-action-btn.delete,
    a.soft-action-btn.delete,
    button.soft-action-btn.delete,
    .soft-action-btn.danger-btn,
    a.soft-action-btn.danger-btn,
    button.soft-action-btn.danger-btn {
        background: #fff1f1 !important;
        color: #d92d20 !important;
        box-shadow: 0 6px 14px rgba(217,45,32,0.18) !important;
    }

        .soft-action-btn.delete:hover,
        a.soft-action-btn.delete:hover,
        button.soft-action-btn.delete:hover,
        .soft-action-btn.danger-btn:hover,
        a.soft-action-btn.danger-btn:hover,
        button.soft-action-btn.danger-btn:hover {
            background: #d92d20 !important;
            color: white !important;
        }
.custom-modal-overlay {
    position: fixed;
    inset: 0;
    background: rgba(17, 24, 39, 0.55);
    backdrop-filter: blur(4px);
    display: flex;
    align-items: center;
    justify-content: center;
    z-index: 9999;
    opacity: 0;
    visibility: hidden;
    transition: all 0.25s ease;
}

    .custom-modal-overlay.show {
        opacity: 1;
        visibility: visible;
    }

.custom-modal-box {
    width: 420px;
    max-width: 92%;
    background: white;
    border-radius: 24px;
    padding: 34px 28px;
    text-align: center;
    box-shadow: 0 20px 60px rgba(0,0,0,0.20);
    transform: translateY(20px) scale(0.96);
    transition: all 0.25s ease;
}

.custom-modal-overlay.show .custom-modal-box {
    transform: translateY(0) scale(1);
}

.custom-modal-icon {
    width: 70px;
    height: 70px;
    margin: 0 auto 18px;
    border-radius: 50%;
    background: #fff1f1;
    color: #d92d20;
    display: flex;
    align-items: center;
    justify-content: center;
    font-size: 34px;
    font-weight: 900;
}

.custom-modal-box h4 {
    font-size: 24px;
    font-weight: 800;
    color: #111827;
    margin-bottom: 10px;
}

.custom-modal-box p {
    color: #667085;
    font-size: 15px;
    margin: 0;
}
.home-hero-panel {
    background: linear-gradient(135deg, #183b73, #244b8f);
    color: white;
    border-radius: 26px;
    padding: 46px 52px;
    display: flex;
    align-items: center;
    justify-content: space-between;
    gap: 40px;
    box-shadow: 0 18px 45px rgba(24,59,115,0.28);
}

.home-hero-badge {
    display: inline-block;
    background: rgba(255,255,255,0.15);
    color: white;
    padding: 8px 16px;
    border-radius: 999px;
    font-size: 13px;
    font-weight: 800;
    margin-bottom: 16px;
}

.home-hero-panel h1 {
    font-size: 46px;
    font-weight: 900;
    margin-bottom: 14px;
}

.home-hero-panel p {
    max-width: 620px;
    color: rgba(255,255,255,0.82);
    font-size: 18px;
    line-height: 1.6;
    margin-bottom: 24px;
}

.home-hero-actions {
    display: flex;
    gap: 12px;
    flex-wrap: wrap;
}

.home-hero-visual {
    width: 430px;
    height: 290px;
    min-width: 430px;
    border-radius: 32px;
    overflow: hidden;
    background: rgba(255,255,255,0.10);
    box-shadow: 0 20px 50px rgba(0,0,0,0.20);
}

    .home-hero-visual img {
        width: 100%;
        height: 100%;
        object-fit: cover;
    }

.home-quick-actions {
    display: grid;
    grid-template-columns: repeat(4, 1fr);
    gap: 18px;
}

.quick-action-card {
    background: white;
    border-radius: 18px;
    padding: 24px;
    text-decoration: none;
    color: #111827;
    box-shadow: 0 8px 22px rgba(0,0,0,0.07);
    border: 1px solid #eef1f5;
    transition: all 0.25s ease;
}

    .quick-action-card:hover {
        transform: translateY(-5px);
        box-shadow: 0 14px 30px rgba(0,0,0,0.11);
        color: #111827;
    }

    .quick-action-card span {
        width: 54px;
        height: 54px;
        border-radius: 16px;
        background: #fff4e8;
        color: #f58200;
        display: flex;
        align-items: center;
        justify-content: center;
        font-size: 26px;
        margin-bottom: 14px;
    }

    .quick-action-card strong {
        display: block;
        color: #183b73;
        font-size: 18px;
        font-weight: 900;
        margin-bottom: 6px;
    }

    .quick-action-card small {
        color: #667085;
        font-weight: 600;
    }

@media (max-width: 992px) {
    .home-hero-panel {
        flex-direction: column;
        align-items: flex-start;
    }

    .home-quick-actions {
        grid-template-columns: repeat(2, 1fr);
    }
}

@media (max-width: 576px) {
    .home-quick-actions {
        grid-template-columns: 1fr;
    }

    .home-hero-panel h1 {
        font-size: 36px;
    }
}

.yk-login-btn {
    background: #183b73 !important;
    color: white !important;
    border: none !important;
    padding: 14px 24px !important;
    border-radius: 28px !important;
    font-weight: 900 !important;
    box-shadow: 0 8px 18px rgba(24,59,115,0.22) !important;
    cursor: pointer;
}
.success-icon {
    background: #edf9f1 !important;
    color: #1f9254 !important;
}
.tracking-icon-img {
    width: 90px;
    height: 90px;
    object-fit: contain;
}
.quick-search-wrapper {
    position: relative;
}

.quick-search-input {
    width: 240px;
    height: 42px;
    border: 1px solid #cbd5e1;
    border-radius: 12px;
    padding: 0 42px 0 14px;
    background: white;
    outline: none;
    transition: 0.2s;
}

    .quick-search-input:focus {
        border-color: #94a3b8;
        box-shadow: 0 0 0 3px rgba(148, 163, 184, 0.15);
    }

.quick-search-icon-btn {
    position: absolute;
    right: 10px;
    top: 50%;
    transform: translateY(-50%);
    border: none;
    background: transparent;
    color: #94a3b8;
    font-size: 16px;
    cursor: pointer;
    padding: 0;
}

    .quick-search-icon-btn:hover {
        color: #64748b;
    }
.table-action-buttons {
    display: flex;
    justify-content: flex-end;
    align-items: center;
    gap: 8px;
    flex-wrap: nowrap;
}

    .table-action-buttons .soft-action-btn {
        white-space: nowrap;
    }