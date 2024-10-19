import React from "react";
import { Navbar, NavbarItem, NavbarSection } from "../components/navbar";
import { Link } from "../components/link";
import Logo from "./Logo";

export default function NavbarExample() {
  return (
    <Navbar>
      <Link href="/" aria-label="Home">
        <Logo />
      </Link>
      <NavbarSection>
        <NavbarItem href="/" current>
          Home
        </NavbarItem>
        <NavbarItem href="/events">Events</NavbarItem>
        <NavbarItem href="/orders">Orders</NavbarItem>
      </NavbarSection>
    </Navbar>
  );
}

// import { Link } from '@/components/link'
// import { Navbar, NavbarItem, NavbarSection } from '@/components/navbar'
// import { Logo } from './logo'
