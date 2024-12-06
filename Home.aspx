<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Telecom_Company_Team_9.Home" %>

<asp:Content runat="server" ID="Content2" ContentPlaceHolderID="HeadContent">
    <!-- Page-specific CSS -->
    <link href="/Content/Home.css" rel="stylesheet" type="text/css" />
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <!-- Hero Section -->
    <div class="hero modern-hero">
        <div class="hero-overlay"></div>
        <div class="hero-content">
            <h1 class="hero-title">Welcome to PO27Y Telecom</h1>
            <p class="hero-description">Revolutionizing communication. Connecting people. Empowering businesses.</p>
            <a href="#services" class="btn primary-btn">Explore Our Services</a>
        </div>
    </div>

    <!-- Services Section -->
    <section id="services" class="services-section modern-section">
        <h2 class="section-title">Our Services</h2>
        <div class="services-container">
            <div class="service-card">
                <i class="icon fas fa-wifi"></i>
                <h3>High-Speed Internet</h3>
                <p>Get the fastest and most reliable internet, powered by our cutting-edge infrastructure.</p>
            </div>
            <div class="service-card">
                <i class="icon fas fa-mobile-alt"></i>
                <h3>Mobile Plans</h3>
                <p>Choose from a range of flexible mobile plans to suit your needs, with data, calls, and more.</p>
            </div>
            <div class="service-card">
                <i class="icon fas fa-briefcase"></i>
                <h3>Business Solutions</h3>
                <p>Take your business to the next level with our customized telecom solutions for enterprise clients.</p>
            </div>
        </div>
    </section>

    <!-- About Section -->
    <section id="about" class="about-section modern-section">
        <h2 class="section-title">About PO27Y</h2>
        <div class="about-container">
            <p>PO27Y Telecom is built on innovation, creativity, and the desire to transform the way people communicate. Our company was founded as part of a university project, but with the vision of creating something bigger. We aim to change the telecom industry through advanced technology and personalized services that put our customers first.</p>
            <p>We specialize in providing fast, reliable, and affordable telecom solutions for individuals and businesses alike. Join the PO27Y revolution today!</p>
        </div>
    </section>
</asp:Content>