import React from 'react';
import {Container} from 'reactstrap';
import {NavMenu} from './NavMenu';

export function Layout(props) {
    return (
        <div>
            <NavMenu/>
            <Container tag="main">
                {props.children}
            </Container>
        </div>
    );
}

Layout.displayName = Layout.name
