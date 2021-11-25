import PostForm from './PostForm';
import React, { useState } from 'react';

const CreatePostView = ({data, update}) => {

	return (
		<>
			<h1 className='text-center m-5 font-display'>Kreator nowej pizzy!</h1>
			<div style={{ margin: '1rem auto', width: '350px', maxWidth: '400px' }}>
				<PostForm onFinish={update} submitText='Dodaj!' />
			</div>
		</>
	);
};

export default CreatePostView;