




/*
'===============================================================================
'  LinqHelper.DAO.QuyDinhHinhSuBase
'===============================================================================
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using LinqHelper;
using LinqHelper.Entity;
using LinqHelper.DAO;

namespace LinqHelper.DAO
{
	public class LqQuyDinhHinhSuBase
	{
		public LqProvider provider = new LqProvider();
		
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqQuyDinhHinhSuBase()
		{
			// Nothing for now.
		}
		
		public void Insert(LqQuyDinhHinhSuEntity obj)
		{
			provider.GetTable<LqQuyDinhHinhSuEntity>().InsertOnSubmit(obj);
            provider.SubmitChanges();
		}

		public void Update(LqQuyDinhHinhSuEntity _obj)
		{
			var q = from obj in provider.GetTable<LqQuyDinhHinhSuEntity>()
                    where obj.Id == _obj.Id
                    select obj;
			LqQuyDinhHinhSuEntity tmp = q.First<LqQuyDinhHinhSuEntity>();
			
			tmp.TenQuyDinhHinhSu = _obj.TenQuyDinhHinhSu;
			tmp.IdMaCha = _obj.IdMaCha;
			tmp.MaRutGon = _obj.MaRutGon;
			tmp.MaTp = _obj.MaTp;
			tmp.GhiChu = _obj.GhiChu;
			tmp.LoaiDanhMuc = _obj.LoaiDanhMuc;
			tmp.IdNguoiTao = _obj.IdNguoiTao;
			tmp.NgayTao = _obj.NgayTao;
			tmp.IdNguoiCapNhat = _obj.IdNguoiCapNhat;
			tmp.NgayCapNhat = _obj.NgayCapNhat;
			tmp.NgayHetHan = _obj.NgayHetHan;
			tmp.TrangThai = _obj.TrangThai;
		}
		
		public void Delete(LqQuyDinhHinhSuEntity obj)
		{
			provider.GetTable<LqQuyDinhHinhSuEntity>().DeleteOnSubmit(obj);
            provider.SubmitChanges();
		}
		
		
		public void DeleteById(Guid Id)
		{
			var q = from obj in provider.GetTable<LqQuyDinhHinhSuEntity>()
                    where obj.Id == Id
                    select obj;
					
            LqQuyDinhHinhSuEntity ob = (LqQuyDinhHinhSuEntity)q.First<LqQuyDinhHinhSuEntity>();
            provider.GetTable<LqQuyDinhHinhSuEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTenQuyDinhHinhSu(string TenQuyDinhHinhSu)
		{
			var q = from obj in provider.GetTable<LqQuyDinhHinhSuEntity>()
                    where obj.TenQuyDinhHinhSu == TenQuyDinhHinhSu
                    select obj;
					
            LqQuyDinhHinhSuEntity ob = (LqQuyDinhHinhSuEntity)q.First<LqQuyDinhHinhSuEntity>();
            provider.GetTable<LqQuyDinhHinhSuEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdMaCha(Guid IdMaCha)
		{
			var q = from obj in provider.GetTable<LqQuyDinhHinhSuEntity>()
                    where obj.IdMaCha.Value == IdMaCha
                    select obj;
					
            LqQuyDinhHinhSuEntity ob = (LqQuyDinhHinhSuEntity)q.First<LqQuyDinhHinhSuEntity>();
            provider.GetTable<LqQuyDinhHinhSuEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaRutGon(string MaRutGon)
		{
			var q = from obj in provider.GetTable<LqQuyDinhHinhSuEntity>()
                    where obj.MaRutGon == MaRutGon
                    select obj;
					
            LqQuyDinhHinhSuEntity ob = (LqQuyDinhHinhSuEntity)q.First<LqQuyDinhHinhSuEntity>();
            provider.GetTable<LqQuyDinhHinhSuEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaTp(string MaTp)
		{
			var q = from obj in provider.GetTable<LqQuyDinhHinhSuEntity>()
                    where obj.MaTp == MaTp
                    select obj;
					
            LqQuyDinhHinhSuEntity ob = (LqQuyDinhHinhSuEntity)q.First<LqQuyDinhHinhSuEntity>();
            provider.GetTable<LqQuyDinhHinhSuEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByGhiChu(string GhiChu)
		{
			var q = from obj in provider.GetTable<LqQuyDinhHinhSuEntity>()
                    where obj.GhiChu == GhiChu
                    select obj;
					
            LqQuyDinhHinhSuEntity ob = (LqQuyDinhHinhSuEntity)q.First<LqQuyDinhHinhSuEntity>();
            provider.GetTable<LqQuyDinhHinhSuEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var q = from obj in provider.GetTable<LqQuyDinhHinhSuEntity>()
                    where obj.LoaiDanhMuc == LoaiDanhMuc
                    select obj;
					
            LqQuyDinhHinhSuEntity ob = (LqQuyDinhHinhSuEntity)q.First<LqQuyDinhHinhSuEntity>();
            provider.GetTable<LqQuyDinhHinhSuEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			var q = from obj in provider.GetTable<LqQuyDinhHinhSuEntity>()
                    where obj.IdNguoiTao.Value == IdNguoiTao
                    select obj;
					
            LqQuyDinhHinhSuEntity ob = (LqQuyDinhHinhSuEntity)q.First<LqQuyDinhHinhSuEntity>();
            provider.GetTable<LqQuyDinhHinhSuEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayTao(DateTime NgayTao)
		{
			var q = from obj in provider.GetTable<LqQuyDinhHinhSuEntity>()
                    where obj.NgayTao == NgayTao
                    select obj;
					
            LqQuyDinhHinhSuEntity ob = (LqQuyDinhHinhSuEntity)q.First<LqQuyDinhHinhSuEntity>();
            provider.GetTable<LqQuyDinhHinhSuEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var q = from obj in provider.GetTable<LqQuyDinhHinhSuEntity>()
                    where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                    select obj;
					
            LqQuyDinhHinhSuEntity ob = (LqQuyDinhHinhSuEntity)q.First<LqQuyDinhHinhSuEntity>();
            provider.GetTable<LqQuyDinhHinhSuEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			var q = from obj in provider.GetTable<LqQuyDinhHinhSuEntity>()
                    where obj.NgayCapNhat == NgayCapNhat
                    select obj;
					
            LqQuyDinhHinhSuEntity ob = (LqQuyDinhHinhSuEntity)q.First<LqQuyDinhHinhSuEntity>();
            provider.GetTable<LqQuyDinhHinhSuEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			var q = from obj in provider.GetTable<LqQuyDinhHinhSuEntity>()
                    where obj.NgayHetHan.Value == NgayHetHan
                    select obj;
					
            LqQuyDinhHinhSuEntity ob = (LqQuyDinhHinhSuEntity)q.First<LqQuyDinhHinhSuEntity>();
            provider.GetTable<LqQuyDinhHinhSuEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTrangThai(bool TrangThai)
		{
			var q = from obj in provider.GetTable<LqQuyDinhHinhSuEntity>()
                    where obj.TrangThai == TrangThai
                    select obj;
					
            LqQuyDinhHinhSuEntity ob = (LqQuyDinhHinhSuEntity)q.First<LqQuyDinhHinhSuEntity>();
            provider.GetTable<LqQuyDinhHinhSuEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public LqQuyDinhHinhSuEntity SelectOne(Guid Id)
		{
			var query = from obj in provider.GetTable<LqQuyDinhHinhSuEntity>()
                        where obj.Id == Id
                        select obj;
            return query.First<LqQuyDinhHinhSuEntity>();
		}

		public List<LqQuyDinhHinhSuEntity> SelectAll()
		{
			var query = from obj in provider.GetTable<LqQuyDinhHinhSuEntity>()
                        select obj;
            return query.ToList<LqQuyDinhHinhSuEntity>();
		}
		
		
		public List<LqQuyDinhHinhSuEntity> SelectById(Guid Id)
		{
			var query = from obj in provider.GetTable<LqQuyDinhHinhSuEntity>()
                        where obj.Id == Id
                        select obj;
            return query.ToList<LqQuyDinhHinhSuEntity>();
		}
		
		
		public List<LqQuyDinhHinhSuEntity> SelectByTenQuyDinhHinhSu(string TenQuyDinhHinhSu)
		{
			var query = from obj in provider.GetTable<LqQuyDinhHinhSuEntity>()
                        where obj.TenQuyDinhHinhSu == TenQuyDinhHinhSu
                        select obj;
            return query.ToList<LqQuyDinhHinhSuEntity>();
		}
		
		
		public List<LqQuyDinhHinhSuEntity> SelectByIdMaCha(Guid IdMaCha)
		{
			var query = from obj in provider.GetTable<LqQuyDinhHinhSuEntity>()
                        where obj.IdMaCha.Value == IdMaCha
                        select obj;
            return query.ToList<LqQuyDinhHinhSuEntity>();
		}
		
		
		public List<LqQuyDinhHinhSuEntity> SelectByMaRutGon(string MaRutGon)
		{
			var query = from obj in provider.GetTable<LqQuyDinhHinhSuEntity>()
                        where obj.MaRutGon == MaRutGon
                        select obj;
            return query.ToList<LqQuyDinhHinhSuEntity>();
		}
		
		
		public List<LqQuyDinhHinhSuEntity> SelectByMaTp(string MaTp)
		{
			var query = from obj in provider.GetTable<LqQuyDinhHinhSuEntity>()
                        where obj.MaTp == MaTp
                        select obj;
            return query.ToList<LqQuyDinhHinhSuEntity>();
		}
		
		
		public List<LqQuyDinhHinhSuEntity> SelectByGhiChu(string GhiChu)
		{
			var query = from obj in provider.GetTable<LqQuyDinhHinhSuEntity>()
                        where obj.GhiChu == GhiChu
                        select obj;
            return query.ToList<LqQuyDinhHinhSuEntity>();
		}
		
		
		public List<LqQuyDinhHinhSuEntity> SelectByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var query = from obj in provider.GetTable<LqQuyDinhHinhSuEntity>()
                        where obj.LoaiDanhMuc == LoaiDanhMuc
                        select obj;
            return query.ToList<LqQuyDinhHinhSuEntity>();
		}
		
		
		public List<LqQuyDinhHinhSuEntity> SelectByIdNguoiTao(Guid IdNguoiTao)
		{
			var query = from obj in provider.GetTable<LqQuyDinhHinhSuEntity>()
                        where obj.IdNguoiTao.Value == IdNguoiTao
                        select obj;
            return query.ToList<LqQuyDinhHinhSuEntity>();
		}
		
		
		public List<LqQuyDinhHinhSuEntity> SelectByNgayTao(DateTime NgayTao)
		{
			var query = from obj in provider.GetTable<LqQuyDinhHinhSuEntity>()
                        where obj.NgayTao == NgayTao
                        select obj;
            return query.ToList<LqQuyDinhHinhSuEntity>();
		}
		
		
		public List<LqQuyDinhHinhSuEntity> SelectByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var query = from obj in provider.GetTable<LqQuyDinhHinhSuEntity>()
                        where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                        select obj;
            return query.ToList<LqQuyDinhHinhSuEntity>();
		}
		
		
		public List<LqQuyDinhHinhSuEntity> SelectByNgayCapNhat(DateTime NgayCapNhat)
		{
			var query = from obj in provider.GetTable<LqQuyDinhHinhSuEntity>()
                        where obj.NgayCapNhat == NgayCapNhat
                        select obj;
            return query.ToList<LqQuyDinhHinhSuEntity>();
		}
		
		
		public List<LqQuyDinhHinhSuEntity> SelectByNgayHetHan(DateTime NgayHetHan)
		{
			var query = from obj in provider.GetTable<LqQuyDinhHinhSuEntity>()
                        where obj.NgayHetHan.Value == NgayHetHan
                        select obj;
            return query.ToList<LqQuyDinhHinhSuEntity>();
		}
		
		
		public List<LqQuyDinhHinhSuEntity> SelectByTrangThai(bool TrangThai)
		{
			var query = from obj in provider.GetTable<LqQuyDinhHinhSuEntity>()
                        where obj.TrangThai == TrangThai
                        select obj;
            return query.ToList<LqQuyDinhHinhSuEntity>();
		}
		
		
		

	}
}
